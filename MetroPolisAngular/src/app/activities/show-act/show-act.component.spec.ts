import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowActComponent } from './show-act.component';

describe('ShowActComponent', () => {
  let component: ShowActComponent;
  let fixture: ComponentFixture<ShowActComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowActComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowActComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
